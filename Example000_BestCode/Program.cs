// // Примар хорошего кода (не работает):

// string caption = "Intensive C# Devo text";
// int screenWidthPosition = (Console.WindowWidth - caption.Length) / 2;
// int screenHeightPosition = Console.WindowHeigth / 2;

// DrawText(caption, screenWidthPosition, screenHeightPosition);

// string DrawText(
//     text: caption,
//     left: screenWidthPosition,
//     top: screenHeightPosition
//     );

// // В случайных точках консоли вывести случайные числа ("матрица")

Random r = new Random();
Console.CursorVisible = false;
while (true)
{
    Console.SetCursorPosition(
        left: r.Next(Console.WindowWidth),
        top: r.Next(Console.WindowHeight)
    );
    Console.Write(r.Next(10));
    Thread.Sleep(1000);
}
