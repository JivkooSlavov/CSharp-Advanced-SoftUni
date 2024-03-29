﻿int n = int.Parse(Console.ReadLine());
int rows = n;
int cols = n;
string[] directions = Console.ReadLine().Split(", ").ToArray();
string[, ] field = new string[rows, cols];

int squirrelRow = 0;
int squirrelCol = 0;
int cointOfHazelnuts = 0;
for (int row = 0; row < rows; row++)
{
    string input = Console.ReadLine();
    for (int col = 0; col < cols; col++)
	{
		field[row, col] = input[col].ToString();
		if (field[row,col] == "s")
		{
            squirrelRow = row;
			squirrelCol	= col;
		}
	}
}


foreach (var direction in directions)
{
	if (direction=="left")
	{
		if (!IsInside(field, squirrelRow, squirrelCol -1))
		{
            Console.WriteLine("The squirrel is out of the field.");
            Console.WriteLine($"Hazelnuts collected: {cointOfHazelnuts}");
			Environment.Exit(0);
        }
		else if (field[squirrelRow, squirrelCol-1] == "t")
		{
            Console.WriteLine("Unfortunately, the squirrel stepped on a trap...");
            Console.WriteLine($"Hazelnuts collected: {cointOfHazelnuts}");
            Environment.Exit(0);
        }
		else if (field[squirrelRow, squirrelCol - 1] == "h")
		{
			cointOfHazelnuts++;
		}
		field[squirrelRow, squirrelCol - 1] = "s";
		field[squirrelRow, squirrelCol] = "*";
        squirrelCol--;
	}

    else if (direction == "right")
    {
        if (!IsInside(field, squirrelRow, squirrelCol + 1))
        {
            Console.WriteLine("The squirrel is out of the field.");
            Console.WriteLine($"Hazelnuts collected: {cointOfHazelnuts}");
            Environment.Exit(0);
        }
        else if (field[squirrelRow, squirrelCol + 1] == "t")
        {
            Console.WriteLine("Unfortunately, the squirrel stepped on a trap...");
            Console.WriteLine($"Hazelnuts collected: {cointOfHazelnuts}");
            Environment.Exit(0);
        }
        else if (field[squirrelRow, squirrelCol + 1] == "h")
        {
            cointOfHazelnuts++;
        }
        field[squirrelRow, squirrelCol + 1] = "s";
        field[squirrelRow, squirrelCol] = "*";
        squirrelCol++;
    }

    else if (direction == "up")
    {
        if (!IsInside(field, squirrelRow -1, squirrelCol))
        {
            Console.WriteLine("The squirrel is out of the field.");
            Console.WriteLine($"Hazelnuts collected: {cointOfHazelnuts}");
            Environment.Exit(0);
        }
        else if (field[squirrelRow - 1, squirrelCol] == "t")
        {
            Console.WriteLine("Unfortunately, the squirrel stepped on a trap...");
            Console.WriteLine($"Hazelnuts collected: {cointOfHazelnuts}");
            Environment.Exit(0);
        }
        else if (field[squirrelRow - 1, squirrelCol] == "h")
        {
            cointOfHazelnuts++;
        }
        field[squirrelRow - 1, squirrelCol] = "s";
        field[squirrelRow, squirrelCol] = "*";
        squirrelRow--;
    }
    else if (direction == "down")
    {
        if (!IsInside(field, squirrelRow + 1, squirrelCol))
        {
            Console.WriteLine("The squirrel is out of the field.");
            Console.WriteLine($"Hazelnuts collected: {cointOfHazelnuts}");
            Environment.Exit(0);
        }
        else if (field[squirrelRow + 1, squirrelCol] == "t")
        {
            Console.WriteLine("Unfortunately, the squirrel stepped on a trap...");
            Console.WriteLine($"Hazelnuts collected: {cointOfHazelnuts}");
            Environment.Exit(0);
        }
        else if (field[squirrelRow + 1, squirrelCol] == "h")
        {
            cointOfHazelnuts++;
        }
        field[squirrelRow + 1, squirrelCol] = "s";
        field[squirrelRow, squirrelCol] = "*";
        squirrelRow++;
    }

}
if (cointOfHazelnuts >=3)
{
    Console.WriteLine("Good job! You have collected all hazelnuts!");
    Console.WriteLine($"Hazelnuts collected: {cointOfHazelnuts}");
}
else
{
    Console.WriteLine("There are more hazelnuts to collect.");
    Console.WriteLine($"Hazelnuts collected: {cointOfHazelnuts}");
}

bool IsInside(string[,] field, int row, int col)
{
	return row >= 0 && row < field.GetLength(0) && col >=0 && col <field.GetLength(1);
}