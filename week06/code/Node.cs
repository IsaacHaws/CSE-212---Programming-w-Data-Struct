public class Node {
    public int Data { get; set; }
    public Node? Right { get; private set; }
    public Node? Left { get; private set; }

    public Node(int data) {
        this.Data = data;
    }

    public void Insert(int value) {
        if(Data != value) {
            if (value < Data) {
                // Insert to the left
                if (Left is null)
                    Left = new Node(value);
                else
                    Left.Insert(value);
            }
            else {
                // Insert to the right
                if (Right is null)
                    Right = new Node(value);
                else
                    Right.Insert(value);
            }
        }
    }

    public bool Contains(int value) {
        if(Data == value) {
            return true;
        }
        else {
            if(value < Data) {
                //Search to the Left
                if(Left is null) {
                    return false;
                }
                else {
                    return Left.Contains(value);
                }
            }
            else {
                //Search to the Right
                if(Right is null) {
                    return false;
                }
                else {
                    return Right.Contains(value);
                }
            }
        }
    }

    public int GetHeight() {
        if(Left is null && Right is null) {
            return 1;
        }
        else {
            int leftHeight = 0;
            int rightHeight = 0;
            if(Left is not null) {
                leftHeight = Left.GetHeight() + 1;
            }

            if(Right is not null) {
                rightHeight = Right.GetHeight() + 1;
            }

            if(leftHeight >= rightHeight) {
                return leftHeight;
            }
            else {
                return rightHeight;
            }

        }
    }
}