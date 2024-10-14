# Generador QR

Este proyecto es una aplicación de **Blazor Web App** para generar códigos QR a partir de un texto ingresado por el usuario. Utiliza **MudBlazor** para la interfaz de usuario y **QRCoder** para la generación de códigos QR.

## Características

- Interfaz moderna y receptiva utilizando **MudBlazor**.
- Generación de códigos QR a partir de un texto de hasta 400 caracteres (modificable).
- Opción para descargar el código QR generado en formato PNG.

## Tecnologías utilizadas

- **Blazor Server**: Para la creación de aplicaciones web interactivas.
- **QRCoder**: Librería para la generación de códigos QR.
- **MudBlazor**: Librería de componentes UI para Blazor.

## Requisitos previos

- .NET SDK 8.0.
- Configuración de un proyecto de Blazor Server.
- Referencias de paquetes necesarias:
    ```xml
    <PackageReference Include="MudBlazor" Version="7.11.0" />
    <PackageReference Include="QRCoder" Version="1.6.0" />
    ```
