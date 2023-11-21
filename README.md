# Binary Tree Sum Project

This is a simple C# project to check the sum of nodes on the left and right of a binary tree represented by an array. The project also includes unit tests to validate the behavior in different cases.

## How to Run

1. Clone the repository to your local machine:

    ```bash
    git clone https://github.com/your-username/BinaryTreeSum.git
    ```

2. Open the project in Visual Studio 2022.

3. Run the `BinaryTreeSum` project:

    ```bash
    dotnet run BinaryTreeSum.csproj
    ```

4. The results of the sum of the binary tree sides will be displayed in the console.

## Project Structure

The project consists of the following files:

- `Program.cs`: Contains the main code that creates a binary tree and prints the sum of nodes on the left and right.
- `BinaryTree.cs`: Implements the logic to create the binary tree and calculate the sum of nodes.
- `BinaryTreeTest.cs`: Contains unit tests to ensure the correctness of the binary tree logic.

## Code Informations

The binary tree is represented by an array.

The array elements are nodes in the binary tree, the left child of the node is the array index calculated by the equation "2 * i + 1", and the right child is calculated by "2 * i + 2", where "i" is the node index in the array.

The value -1 in the array means the node has no children.

The algorithm is recursive.

## Example Usage

```csharp
int[] treeArray = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15
                              , 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30 };
BinaryTree binaryTree = new BinaryTree(treeArray);
Console.WriteLine(binaryTree.MajorSum());
```

## Tecnologies

- Visual Studio 2022

- .Net 6
