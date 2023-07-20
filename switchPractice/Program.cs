// SKU = Stock Keeping Unit. 
// SKU value format: <product #>-<2-letter color code>-<size code>
string sku = "01-MN-L";

// Split the SKU string into three parts using the '-' separator
string[] product = sku.Split('-');

string type = "";
string color = "";
string size = "";

// Determine the product type based on the first part of the SKU
switch (product[0])
{
    case "01":
        type = "Sweat shirt";
        break;

    case "02":
        type = "T-Shirt";
        break;
    case "03":
        type = "Sweat pants";
        break;
    default:
        type = "Other"; // If the number does not match any of the cases, its considered "Other"
        break;
}

// Determine the product color based on the second part of SKU
switch (product[1])
{
    case "BL":
        color = "Black";
        break;
    case "MN":
        color = "Maroon";
        break;
    default:
        color = "White";
        break;
}

//Determine the product size on the third part of the SKU
switch (product[2])
{
    case "S":
        size = "Small";
        break;
    case "M":
        size = "Medium";
        break;
    case "L":
        size = "Large";
        break;
    default:
        size = "One Size Fits All";
        break;
}
Console.WriteLine($"Product: {size} {color} {type}");