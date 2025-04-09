# Ticket-de-Turno
### ✅ **1. Configuración inicial del proyecto**

- [x]  Crear solución en Visual Studio (Windows Forms App VB.NET).
    
- [x]  Crear carpetas: `Model`, `View`, `Controller`.
    
- [ ]  Establecer `Sub Main()` en `ApplicationEvents.vb` para definir punto de entrada.
    
- [ ] Crear archivo `Program.vb` o usar `ApplicationEvents.vb` como entry point personalizado si lo prefieres.
    

---

### ✅ **2. Modelo de base de datos**

- [x]  Crear archivo de base de datos en **Access (.accdb)**.
    
- [x]  Crear tablas: `Administrador`, `Alumno`, `Municipio`, `Solicitud`.
    
- [x]  Definir relaciones y llaves primarias/foráneas.
    

---

### ✅ **3. Modelo (Model)**

- [x]  Crear clases: `Administrador.vb`, `Alumno.vb`, `Municipio.vb`, `Solicitud.vb`.
    
- [ ]  Cada clase debe mapearse con los campos de su tabla correspondiente.
    
- [ ]  Incluir validaciones internas (por ejemplo, CURP con expresión regular).
    
- [ ]  Implementar métodos CRUD como funciones compartidas (`Shared`) o instanciadas.
    

---

### ✅ **4. Vista (View)**

- [ ]  Crear formularios:
    
    - [ ]  `LoginForm`
    
    - [ ] `DashboardForm`
    
    - [ ] `SolicitudForm`
    
    - [ ] `ConsultaForm`
    
    - [ ] `CRUDMunicipioForm`
    
    - [ ] `CRUDAministradorForm`
        
- [ ] Agregar menú principal para navegación.
    
- [ ] Agregar botón de cierre seguro de sesión y aplicación.
    
- [ ] En `SolicitudForm`, permitir crear y modificar solicitudes públicas con CURP y Número de Turno.
    

---

### ✅ **5. Controlador (Controller)**

- [ ] Crear clases como: `AuthController.vb`, `SolicitudController.vb`, `AlumnoController.vb`, `TurnoController.vb`.
    
- [ ] Conectar Vista con Modelo mediante los controladores.
    
- [ ] Gestionar la lógica de negocio:
    
    - [ ] Validar CURP
        
    - [ ] Asignación de turnos por municipio
        
    - [ ] Actualización de estado
        
    - [ ] Manejo de errores
        

---

### ✅ **6. Funcionalidades clave**

- [ ] **Login** de administradores.
    
- [ ] Validación de CURP (formato correcto antes de guardar).
    
- [ ] Generación y consulta de turnos.
    
- [ ] Actualización de estado: “Pendiente” / “Resuelto”.
    
- [ ] CRUD completo para catálogos (`Municipio`, `Administrador`, etc).
    
- [ ] Dashboard con gráfico (puedes usar gráficos de MSChart o librerías integradas).
    

---

### ✅ **7. Extras y entregables**

- [ ] Uso de 2 patrones de diseño (por ejemplo: Singleton para conexión y DAO para acceso a datos).
    
- [ ] Implementar cierre seguro (destruir variables globales, cerrar conexión).
    
- [ ] Crear documento digital de asignación de tareas por integrante.
    
- [ ] Crear y mantener repositorio en GitHub con commits claros por cada integrante.
    
- [ ] Pruebas funcionales antes de entrega.
    
- [ ] Preparar presentación para exposición.
    

