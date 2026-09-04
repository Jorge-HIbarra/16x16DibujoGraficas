using Raylib_cs;

Raylib.InitWindow(800, 600, "Dibujo Camarón");
Raylib.SetTargetFPS(60);

while (!Raylib.WindowShouldClose())
{
    Raylib.BeginDrawing();
    Raylib.ClearBackground(Color.RayWhite);

int origenX = 200;   
int origenY = 100;  
int celda = 25; 
Color customYellow = new Color(255, 249, 189);
Color customRed = new Color(153, 0, 48);
Color customDarkRed = new Color(51, 8, 21);
Color customLightRed = new Color(199, 12, 71);
Color customPink = new Color(214, 84, 105);
Color customOtherRed = new Color(105, 5, 37);

    int[,] imagen = {
  { 1, 1, 1, 1, 1, 1, 0, 0, 1, 0, 1, 1, 0, 1, 1, 1 },
  { 1, 1, 1, 1, 1, 0, 1, 1, 0, 1, 0, 1, 0, 1, 1, 1 },
  { 1, 1, 1, 1, 1, 1, 0, 2, 0, 5, 2, 0, 1, 1, 1, 1 },
  { 1, 1, 1, 1, 1, 2, 2, 4, 0, 3, 0, 2, 1, 1, 1, 1 },
  { 1, 1, 1, 1, 2, 4, 3, 0, 4, 4, 9, 9, 2, 1, 1, 1 },
  { 1, 1, 1, 2, 4, 3, 4, 3, 3, 3, 4, 8, 9, 5, 1, 1 },
  { 1, 1, 2, 4, 3, 4, 3, 4, 5, 9, 9, 4, 3, 5, 1, 1 },
  { 1, 1, 5, 4, 3, 3, 5, 2, 0, 2, 8, 9, 4, 2, 1, 1 },
  { 1, 1, 5, 4, 3, 3, 2, 0, 1, 0, 2, 2, 2, 1, 1, 1 },
  { 1, 1, 1, 2, 3, 4, 2, 1, 0, 1, 0, 1, 1, 1, 1, 1 },
  { 1, 1, 1, 5, 4, 3, 4, 5, 5, 1, 0, 1, 1, 1, 1, 1 },
  { 1, 1, 1, 1, 2, 4, 3, 4, 4, 5, 2, 1, 1, 1, 1, 1 },
  { 1, 1, 1, 1, 1, 2, 5, 5, 2, 5, 4, 5, 1, 1, 1, 1 },
  { 1, 1, 1, 1, 1, 1, 1, 1, 5, 4, 5, 1, 1, 1, 1, 1 },
  { 1, 1, 1, 1, 1, 1, 1, 1, 1, 5, 1, 1, 1, 1, 1, 1 },
  { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 },
  { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 },
};

for (int fila = 0; fila < 16; fila++)
for (int col = 0; col < 16; col++)
{
    int x = origenX + col * celda;
    int y = origenY + fila * celda;
    if (imagen[fila, col] == 0)
        Raylib.DrawRectangle(x, y, celda, celda, customDarkRed);
    if (imagen[fila, col] == 1)
        Raylib.DrawRectangle(x, y, celda, celda, customYellow);
    if (imagen[fila, col] == 2)
        Raylib.DrawRectangle(x, y, celda, celda, customRed);
    if (imagen[fila, col] == 3)
        Raylib.DrawRectangle(x, y, celda, celda, customLightRed);
    if (imagen[fila, col] == 4)
        Raylib.DrawRectangle(x, y, celda, celda, customPink);
    if (imagen[fila, col] == 5)
        Raylib.DrawRectangle(x, y, celda, celda, customOtherRed);
    if (imagen[fila, col] == 9)
        Raylib.DrawRectangle(x, y, celda, celda, Color.Black);
}

    Raylib.EndDrawing();
}

Raylib.CloseWindow();
