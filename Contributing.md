# ProyectoFinalProg3

## Para poder aportar en este proyecto agregando formularios y logica de negocio para la caja es necesario conocer este proyecto


### GUIA

# Paso 1: Crear Formulario

 1.1 Crearemos el formulario y agregamos el diseño creado, para este ejemplo haremos un CRUD (Create, Read, Update, Delete) Nota: Delete para nosotros es un desactivar
 ![Alt Image]( 1)

# Paso 2: Agregar repositorio
   2.1 Vamos al code behinde del formulario
  ![Alt Image]( 2)
   2.2 Agregamos las siguientes propiedades:
          private UnitOfWork unitOfWork: Sirve para crear el repositorio;
          private BaseRepository<EntityWished> _userRepository: Repositorio de cada clase;

Nota> Para el proceso del CRUD (no es necesario volver a codear las partes, insert, delete, getall, update) para ellos simplemente instanciamos un repositorio
      del tipo de la clase necesitada y listo

    2.3  Agregamos al constructor el siguiente codigo para instanciar el repositorio y el UnitOfWork
             unitOfWork = new UnitOfWork();
            _userRepository = unitOfWork.Repository<User>();

3. Usar Repositorio

1. Cargar datos : (Consigue un IQueryable de todos los datos alojado en la base de datos) 
  		var users = _userRepository.GetAll().ToArray();
                listUsers.Items.AddRange(users); 

2. Insert: (le pasamos como parametro un objeto con los datos a agregar.)


            _userRepository.Insert(new User()
            {
                UserName = txtUserName.Text,
                Password = txtPassword.Text,
                Email = txtEmail.Text,
                IsCasher = chkIsCasher.Checked
            });

3. Update: 
 	1. Creamos un objeto del tipo de entidad creada en este caso User
		        public User SelectedUser { get; set; }

	2. En el listbox cuando se selecciona el objeto lo referenciamos con el objeto seleccionado

  		if (listUsers.SelectedIndex != -1)
                	SelectedUser = listUsers.SelectedItem as User;

		Nota: Tener encuenta que debe pasar los datos del SelectedUser a las propiedades como se muestra abajo	

	3. En el boton de actualizar agregamos el siguiente codigo
  		SelectedUser.UserName = txtUserName.Text;
                SelectedUser.Password = txtPassword.Text;
                SelectedUser.Email = txtEmail.Text;
                SelectedUser.IsCasher = chkIsCasher.Checked;

                _userRepository.Update(SelectedUser);   (Actualiza la entidad enviada)

4. Desactivar:

		SelectedUser = _userRepository.GetById(1); (Seleccionamos el usuario deseado
                SelectedUser.IsEnabled = false || true; (Aplicamos el estado el falso or true que deseemos
                _userRepository.Update(SelectedUser); (Actualizamos los cambios)

5. Delete:
	
    		SelectedUser = _userRepository.GetById(1); Seleccionamos el usuario  y lo pasamos al metodo delete del repositorio
                _userRepository.Delete(SelectedUser);




6. Como crear una clase: En el proyecto DatabaseProject en la carpeta Models  agregamos una entidad que herede de BaseEntity
  La clase padre tiene los siguientes atributos

        public long Id { get; set; }
        public DateTime CreationTime { get; private set; } = DateTime.Now; 


7. Agregar las propiedades deseadas a la entidad creada.
8. Ir a la carpeta Contexts y luego al archivo CashDbContext y agregar la entidad deseada debajo del comentario // Mis Modelso o Entidadades
        // Mis modelos o entidades

        public DbSet<Models.User> Users { get; set; }

9. Ir al Package Manager Consoler para crear la entidad en la base de datos con la siguiente sentencia
	9.1 Add-Migration '[NOMBRE DESEADO PARA EL MIGRATION]' (El nombre preferiblemente es con los cambios agregados a la base de datos ejemplo: entity_user_added) Sirve para crear el query que se ejecutara posteriormente en la base de datos
	9.2 Update-Database (Sirve para ejecutar los cambios del migration en la base de datos)