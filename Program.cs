using Raylib_cs;

Raylib.InitWindow(800, 600, "Pixel Canvas");
Raylib.SetTargetFPS(60);

while (!Raylib.WindowShouldClose())
{
    Raylib.BeginDrawing();
    Raylib.ClearBackground(Color.RayWhite);

    Raylib.EndDrawing();
}

Raylib.CloseWindow();
