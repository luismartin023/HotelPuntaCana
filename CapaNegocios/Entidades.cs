namespace CapaNegocios
{

    public abstract class EntidadBase
    {
        // Propiedad común a todas las entidades
        public int Id { get; set; }

        // ── Constructor vacío
        protected EntidadBase()
        {
            Id = 0;
        }

        // ── Constructor con parámetro
        protected EntidadBase(int id)
        {
            Id = id;
        }

        // ── MÉTODO ABSTRACTO: cada entidad implementa su propia validación
        public abstract bool Validar();

        // ── MÉTODO ABSTRACTO: cada entidad describe sus datos clave
        public abstract string ObtenerResumen();

        // ── MÉTODO VIRTUAL: se puede sobrescribir en hijos
        public virtual string ObtenerDescripcion()
        {
            return $"Entidad ID: {Id}";
        }

        // ── MÉTODO VIRTUAL: validación con mensaje
        public virtual bool EsValido(out string mensaje)
        {
            bool valido = Validar();
            mensaje = valido ? "OK" : "Datos incompletos o inválidos.";
            return valido;
        }

        // ── MÉTODO NORMAL: aplica a todas las entidades
        public bool EstaPersistida()
        {
            return Id > 0;
        }
    }

    public abstract class PersonaBase : EntidadBase
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }

        // ── Constructor vacío
        protected PersonaBase() : base()
        {
            Nombre = string.Empty;
            Apellido = string.Empty;
        }

        // ── Constructor con parámetros
        protected PersonaBase(int id, string nombre, string apellido) : base(id)
        {
            Nombre = nombre;
            Apellido = apellido;
        }

        // ── MÉTODO NORMAL: disponible para todos los descendientes
        public string NombreCompleto()
        {
            return $"{Nombre} {Apellido}".Trim();
        }

        // ── MÉTODO ABSTRACTO: cada tipo de persona valida de forma distinta
        public abstract bool TieneDatosContacto();

        // ── MÉTODO VIRTUAL: sobrescribible por cada hijo
        public override string ObtenerDescripcion()
        {
            return $"Persona: {NombreCompleto()} (ID: {Id})";
        }
    }

    public class Huesped : PersonaBase
    {
        public string Cedula { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public string Nacionalidad { get; set; }

        // ── Constructor vacío
        public Huesped() : base()
        {
            Cedula = string.Empty;
            Telefono = string.Empty;
            Email = string.Empty;
            Nacionalidad = string.Empty;
        }

        // ── Constructor completo
        public Huesped(int id, string nombre, string apellido,
                       string cedula, string telefono, string email, string nacionalidad)
            : base(id, nombre, apellido)
        {
            Cedula = cedula;
            Telefono = telefono;
            Email = email;
            Nacionalidad = nacionalidad;
        }

        // ── MÉTODO ABSTRACTO implementado: valida campos obligatorios
        public override bool Validar()
        {
            return !string.IsNullOrWhiteSpace(Nombre) &&
                   !string.IsNullOrWhiteSpace(Apellido) &&
                   !string.IsNullOrWhiteSpace(Cedula);
        }

        // ── MÉTODO ABSTRACTO implementado desde PersonaBase
        public override bool TieneDatosContacto()
        {
            return !string.IsNullOrWhiteSpace(Telefono) ||
                   !string.IsNullOrWhiteSpace(Email);
        }

        // ── MÉTODO ABSTRACTO implementado: resumen para mostrar en pantalla
        public override string ObtenerResumen()
        {
            return $"Huésped: {NombreCompleto()} | Cédula: {Cedula} | {Nacionalidad}";
        }

        // ── MÉTODO VIRTUAL sobrescrito
        public override string ObtenerDescripcion()
        {
            return $"Huésped [{Id}]: {NombreCompleto()} - {Cedula}";
        }
    }

    public class Usuario : PersonaBase
    {
        public string NombreUsuario { get; set; }
        public string Clave { get; set; }
        public string Rol { get; set; }
        public bool Activo { get; set; }

        // ── Constructor vacío
        public Usuario() : base()
        {
            NombreUsuario = string.Empty;
            Clave = string.Empty;
            Rol = "Recepcionista";
            Activo = true;
        }

        // ── Constructor con parámetros
        public Usuario(int id, string nombre, string apellido,
                       string nombreUsuario, string clave, string rol)
            : base(id, nombre, apellido)
        {
            NombreUsuario = nombreUsuario;
            Clave = clave;
            Rol = rol;
            Activo = true;
        }

        public override bool Validar()
        {
            return !string.IsNullOrWhiteSpace(Nombre) &&
                   !string.IsNullOrWhiteSpace(NombreUsuario) &&
                   !string.IsNullOrWhiteSpace(Clave);
        }

        public override bool TieneDatosContacto() => true;  // Usuario del sistema siempre válido

        public override string ObtenerResumen()
        {
            return $"Usuario: {NombreUsuario} | Rol: {Rol}";
        }

        // ── MÉTODO COMO FUNCIÓN: retorna true si es admin
        public bool EsAdministrador()
        {
            return Rol == "Admin";
        }

        // ── MÉTODO VIRTUAL sobrescrito
        public override string ObtenerDescripcion()
        {
            return $"Usuario [{NombreUsuario}] — {Rol} — {(Activo ? "Activo" : "Inactivo")}";
        }
    }

    public class TipoHabitacion : EntidadBase
    {
        public string Nombre { get; set; }
        public decimal PrecioPorNoche { get; set; }
        public int Capacidad { get; set; }
        public string Descripcion { get; set; }

        // ── Constructor vacío
        public TipoHabitacion() : base()
        {
            Nombre = string.Empty;
            Descripcion = string.Empty;
        }

        // ── Constructor con parámetros
        public TipoHabitacion(int id, string nombre, decimal precio, int capacidad, string desc)
            : base(id)
        {
            Nombre = nombre;
            PrecioPorNoche = precio;
            Capacidad = capacidad;
            Descripcion = desc;
        }

        public override bool Validar()
        {
            return !string.IsNullOrWhiteSpace(Nombre) &&
                   PrecioPorNoche > 0 &&
                   Capacidad > 0;
        }

        public override string ObtenerResumen()
        {
            return $"{Nombre} — RD$ {PrecioPorNoche:N2}/noche — Capacidad: {Capacidad}";
        }

        // ── MÉTODO COMO FUNCIÓN: precio formateado
        public string PrecioFormateado()
        {
            return $"RD$ {PrecioPorNoche:N2}";
        }
    }

    public class Habitacion : EntidadBase
    {
        public int NumeroHabitacion { get; set; }
        public int IdTipoHabitacion { get; set; }
        public TipoHabitacion TipoHabitacion { get; set; }
        public string Estado { get; set; }

        // ── Constructor vacío
        public Habitacion() : base()
        {
            Estado = "Disponible";
        }

        // ── Constructor con parámetros
        public Habitacion(int id, int numero, int idTipo, string estado) : base(id)
        {
            NumeroHabitacion = numero;
            IdTipoHabitacion = idTipo;
            Estado = estado;
        }

        public override bool Validar()
        {
            return NumeroHabitacion > 0 && IdTipoHabitacion > 0;
        }

        public override string ObtenerResumen()
        {
            return $"Hab. {NumeroHabitacion} — {Estado}";
        }

        // ── MÉTODO VIRTUAL: se puede especializar según tipo
        public virtual bool EstaDisponible()
        {
            return Estado == "Disponible";
        }

        // ── MÉTODO COMO FUNCIÓN: retorna ícono del estado
        public string ObtenerEstadoIcono()
        {
            return Estado switch
            {
                "Disponible" => "✅ Disponible",
                "Ocupada" => "🔴 Ocupada",
                "Limpieza" => "🧹 En limpieza",
                _ => $"⚪ {Estado}"
            };
        }
    }

    public class Reserva : EntidadBase
    {
        public int IdHabitacion { get; set; }
        public int IdHuesped { get; set; }
        public DateTime FechaEntrada { get; set; }
        public DateTime FechaSalida { get; set; }
        public string Canal { get; set; }
        public string Estado { get; set; }

        // ── Constructor vacío
        public Reserva() : base()
        {
            FechaEntrada = DateTime.Today;
            FechaSalida = DateTime.Today.AddDays(1);
            Estado = "Pendiente";
            Canal = string.Empty;
        }

        // ── Constructor con parámetros
        public Reserva(int id, int idHabitacion, int idHuesped,
                       DateTime entrada, DateTime salida, string canal, string estado)
            : base(id)
        {
            IdHabitacion = idHabitacion;
            IdHuesped = idHuesped;
            FechaEntrada = entrada;
            FechaSalida = salida;
            Canal = canal;
            Estado = estado;
        }

        public override bool Validar()
        {
            return IdHabitacion > 0 &&
                   IdHuesped > 0 &&
                   FechaSalida > FechaEntrada &&
                   !string.IsNullOrWhiteSpace(Canal);
        }

        public override string ObtenerResumen()
        {
            return $"Reserva #{Id} | Hab: {IdHabitacion} | {FechaEntrada:dd/MM/yy}→{FechaSalida:dd/MM/yy} | {Estado}";
        }

        // ── MÉTODO COMO FUNCIÓN: calcula cantidad de noches
        public int CalcularNoches()
        {
            return (FechaSalida - FechaEntrada).Days;
        }

        // ── MÉTODO COMO FUNCIÓN: calcula total dado un precio por noche
        public decimal CalcularTotal(decimal precioPorNoche)
        {
            return CalcularNoches() * precioPorNoche;
        }

        // ── MÉTODO VIRTUAL: lógica de cancelación sobrescribible
        public virtual bool PuedeCancelarse()
        {
            return Estado == "Pendiente" || Estado == "Confirmada";
        }

        // ── MÉTODO COMO FUNCIÓN: retorna ícono del estado
        public string ObtenerEstadoIcono()
        {
            return Estado switch
            {
                "Confirmada" => "✅ Confirmada",
                "Pendiente" => "⏳ Pendiente",
                "Cancelada" => "❌ Cancelada",
                _ => $"⚪ {Estado}"
            };
        }
    }


    public class Pago : EntidadBase
    {
        public int IdReserva { get; set; }
        public DateTime FechaPago { get; set; }
        public decimal Monto { get; set; }
        public string MetodoPago { get; set; }

        // ── Constructor vacío
        public Pago() : base()
        {
            FechaPago = DateTime.Today;
            MetodoPago = string.Empty;
        }

        // ── Constructor con parámetros
        public Pago(int id, int idReserva, DateTime fechaPago, decimal monto, string metodo)
            : base(id)
        {
            IdReserva = idReserva;
            FechaPago = fechaPago;
            Monto = monto;
            MetodoPago = metodo;
        }

        public override bool Validar()
        {
            return IdReserva > 0 && Monto > 0 && !string.IsNullOrWhiteSpace(MetodoPago);
        }

        public override string ObtenerResumen()
        {
            return $"Pago Reserva #{IdReserva} — RD$ {Monto:N2} — {MetodoPago}";
        }

        // ── MÉTODO COMO FUNCIÓN: monto formateado
        public string MontoFormateado()
        {
            return $"RD$ {Monto:N2}";
        }
    }
}
