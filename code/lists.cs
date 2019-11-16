IReadOnlyList&lt;string> shoppingList = new List&lt;string> { "catfish", 
                    "water", "tulips", "blue paint" };

var shoppingListMutable = new List&lt;string> { "catfish", "water",
        "tulips", "blue paint" };
shoppingListMutable[1] = "bottle of water";
shoppingListMutable.Add("bucket");