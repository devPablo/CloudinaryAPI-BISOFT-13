# CloudinaryAPI-BISOFT-13

Explicación e implementación del API de Cloudinary para el curso de Proyecto de Ingeniería del Software 2.

## ¿Qué es?

Cloudinary es una solución de software como servicio (SaaS) para administrar todos los recursos multimedia de su aplicación web o móvil en la nube. Cloudinary ofrece una solución de extremo a extremo para todas sus necesidades de imagen y video, incluyendo carga, almacenamiento, administración, manipulación y entrega optimizada. La carga, el procesamiento y la entrega de los medios se manejan en los servidores de Cloudinary, que se escalan automáticamente para manejar altas cargas y ráfagas de tráfico.

## ¿Para qué sirve?

Cloudinary es un servicio en la nube que sirve para almacenar nuestras imágenes en su servidor y disponer de ellas mediante una url personalizada.
Cloudinary utiliza el Akamai’s worldwide CDN. Esta red de distribución de contenidos permite que el usuario obtenga nuestros recursos del servidor más cercano al que nos los pide, optimizando el tiempo de entrega de los mismos en comparación con tenerlos alojados sólo en un servidor. Además Cloudinary implementa un excelente cacheo de los recursos que evita tener que buscarlos en un servidor con cada petición, mejorando el tiempo de carga de los mismos.


## ¿Cuáles son los requisitos?

Cuenta en Cloudinary (gratis): Primeramente, para hacer uso de la plataforma “Cloudinary”, es necesario crear una cuenta a la cual estará ligado nuestro repositorio. La creación de dicha cuenta está disponible a través del siguiente enlace: [Cloudinary](https://cloudinary.com/)
 
#### Datos de la cuenta:
- `"Cloudname" - Nombre del servidor.`
- `"Api Key" - Llave del API.`
- `"Api Secret" - Código único de acceso al api.`

#### NuGet Package:
- `Agregar "CloudinaryDotNet".`

#### Referencias al NuGet Package:
- `using CloudinaryDotNet;`
- `using CloudinaryDotNet.Actions;`


## ¿Cómo se usa?

La utilización del API de Cloudinary requiere el uso de pocos métodos para subir una imagen al servicio de almacenamiento. El uso es sencillo, primeramente necesitamos importar el paquete NuGet previamente mencionado. Se necesitará la creación de una instancia de “Account”, esto llevará los datos de la cuenta como parámetros.

Posteriormente se inicializará una instancia de “Cloudinary”, donde pasaremos por parámetro la cuenta recién instanciada. Con la instancia de “Cloudinary”, se podrá realizar varias acciones, pero la más relevante es “Upload()”, método el cual recibe como parámetro “ImageUploadParams”. Este deberá ser instanciado y asignarle como atributo un “FileDescription”, el cual tendrá la ruta de la imágen por subir. 

A partir de este punto, los datos necesarios han sido implementados. Finalmente se utilizará el método previamente mencionado: Upload(). Este se encargará de subir la imágen seleccionada al servicio de almacenamiento de imágenes y videos de Cloudinary.


## ¿Dónde encontrar documentación?

Debido al gran crecimiento de la plataforma Cloudinary, este se ha visto obligado a expandir la integración de sus servicios en la nube. Por ende, hoy en día, tienen una gran compatibilidad y soporte con muchos lenguajes de programación y entornos.
La documentación del API para la implementación del servicio de Cloudinary, se puede encontrar en la página oficial, específicamente aquí: [Referencias de Cloudinary](https://cloudinary.com/documentation/cloudinary_references)


## ¿NuGets recomendados?

Existen diferentes paquetes NuGet para la utilización del servicio de Cloudinary, siendo algunos de estos públicos creados por la comunidad. Sin embargo, el paquete NuGet recomendado, es el oficial creado por Cloudinary. El nombre de este es: “Cloudinary DotNet” Library. Se puede encontrar en el siguiente enlace: [CloudinaryDotNet](https://www.nuget.org/packages/CloudinaryDotNet/)
