using OrchardCore.Modules.Manifest;

[assembly: Module(
    Name = "Carousel Widget",
    Author = "David Hayden",
    Website = "https://www.davidhayden.me",
    Version = "1.8.3",
    Description = "Adds a Bootstrap 5 Carousel Widget.",
    Dependencies = new[] { "OrchardCore.ContentFields", "OrchardCore.Flows", "OrchardCore.Media", "OrchardCore.Widgets" },
    Category = "Content"
)]