string caption = "Intensive C# Devo text";
int screenWidthPosition = (Console.WindowWidth - caption.Length) / 2;
int screenHeightPosition = Console.WindowHiegth / 2;

DrawText(caption, screenWidthPosition, screenHeightPosition);

DrawText(
    text: caption,
    left: screenWidthPosition,
    top: screenHeightPosition
    );
