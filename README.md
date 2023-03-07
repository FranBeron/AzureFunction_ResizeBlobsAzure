# AzureFunction_ResizeBlobsAzure

  Esta Azure Function escrita en .NET está diseñada para redimensionar imágenes alojadas en un contenedor de almacenamiento de blobs de Azure y almacenar las imágenes     redimensionadas en otro contenedor.

# Cómo funciona
   La función se activa cada vez que se carga una imagen en el contenedor de origen. Luego, utiliza la biblioteca SixLabors.ImageSharp para redimensionar la imagen          según las dimensiones especificadas en el código y la almacena en el contenedor de destino.

# Cómo usar la función
  -Clona o descarga el repositorio.
  -Abre el proyecto en Visual Studio o en cualquier otro editor de código.
  -Configura los valores de la cadena de conexión para los contenedores de origen y destino en el archivo local.settings.json o en las variables de entorno en el portal    de Azure.
  -Implementa la función en tu suscripción de Azure.
  -Carga las imágenes en el contenedor de origen y verifica que se han creado versiones redimensionadas en el contenedor de destino.

# Dependencias
  La función depende de la biblioteca SixLabors.ImageSharp para redimensionar las imágenes.

# Contribuir
  Si deseas contribuir a este proyecto, por favor envía un pull request o abre un issue.

# Licencia
  Este proyecto se distribuye bajo la licencia MIT. Consulta el archivo LICENSE para obtener más detalles.
