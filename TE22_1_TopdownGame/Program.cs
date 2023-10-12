﻿using Raylib_cs;
using System.Numerics;

Raylib.InitWindow(800, 600, "Hello");
Raylib.SetTargetFPS(60);


// int x = 0;
// Vector2 position = new Vector2(0, 0);
// Vector2 movement = new Vector2(2, 1);

Color hotPink = new Color(255, 105, 180, 255);

Rectangle characterRect = new Rectangle(300, 400, 64, 64);
Texture2D characterImage = Raylib.LoadTexture("gubbe.png");

while (!Raylib.WindowShouldClose())
{
  // position += movement;

  if (Raylib.IsKeyDown(KeyboardKey.KEY_RIGHT))
  {

  }

  // characterRect.x += movement.X;
  // characterRect.y += movement.Y;

  // x++;
  Raylib.BeginDrawing();
  Raylib.ClearBackground(Color.GOLD);

  Raylib.DrawTexture(characterImage, (int) characterRect.x, (int) characterRect.y, Color.WHITE);

  // Raylib.DrawCircleV(position, 50, hotPink);
  // Raylib.DrawCircle(x, 300, 50, hotPink);
  
  // Raylib.DrawRectangle(10, 40, 300, 50, Color.BLACK);
  // Raylib.DrawRectangleRec(wall, Color.WHITE);

  Raylib.EndDrawing();
}