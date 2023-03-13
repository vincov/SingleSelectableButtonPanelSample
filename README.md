SingleSelectableButtonPanel
=====================
I created this WPF User Control because I had the necessity of letting user select one option from a variable list of domain objects and I didn't want to use the classic RadioButton control.

![](https://i.imgur.com/sXdZzs1.gif)

### Usage

```csharp
// Get your list of domain objects
var users = new List<Profile>
{
	new Profile { Name = "Bill Gates"},
	new Profile { Name = "Linus Torvalds" },
	new Profile { Name = "Steve Jobs" }
};

// Create the UserControl and pass your list to it
var panel = new SingleSelectableButtonPanel(users);

// Put the control where you need it
ContainerGrid.Children.Add(panel);
```