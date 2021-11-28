namespace Leetcode;

public static class Problem21
{
    // NOTE: This solution modifies the original lists by rearranging the nodes, it does not create new nodes
    public static ListNode MergeTwoLists(ListNode list1, ListNode list2)
    {
        var cursor1 = list1;
        var cursor2 = list2;

        ListNode head = null, cursor = null, next = null;

        while (cursor1 != null || cursor2 != null)
        {
            // If there are no more items in the first list, add from 2nd list
            if (cursor1 == null)
            {
                next = cursor2.next; // Save the next node

                // If we don't have a head yet, set this node as head
                if (head == null)
                {
                    head = cursor2;
                    cursor = head;
                }
                // Otherwise set it as the next of the current node and move the cursor
                else
                {
                    cursor.next = cursor2; // Se the new node in the merged list
                    cursor = cursor.next; // Advance cursor
                }

                cursor2.next = null; // This node was detached from the original list so it doesn't need a next anymore
                cursor2 = next; // Set its old next as the new head of the partial list
            }
            // If there are no more items in the second list, add from the 1st
            else if (cursor2 == null)
            {
                next = cursor1.next; // Save the next node

                // If we don't have a head yet, set this node as head
                if (head == null)
                {
                    head = cursor1;
                    cursor = head;
                }
                // Otherwise set it as the next of the current node and move the cursor
                else
                {
                    cursor.next = cursor1; // Se the new node in the merged list
                    cursor = cursor.next; // Advance cursor
                }

                cursor1.next = null; // This node was detached from the original list so it doesn't need a next anymore
                cursor1 = next; // Set its old next as the new head of the partial list
            }
            // Otherwise we have to compare the two items to see which one we take first
            else
            {
                if (cursor1.val <= cursor2.val)
                {
                    next = cursor1.next; // Save the next node

                    // If we don't have a head yet, set this node as head
                    if (head == null)
                    {
                        head = cursor1;
                        cursor = head;
                    }
                    // Otherwise set it as the next of the current node and move the cursor
                    else
                    {
                        cursor.next = cursor1; // Se the new node in the merged list
                        cursor = cursor.next; // Advance cursor
                    }

                    cursor1.next = null; // This node was detached from the original list so it doesn't need a next anymore
                    cursor1 = next; // Set its old next as the new head of the partial list
                }
                else
                {
                    next = cursor2.next; // Save the next node

                    // If we don't have a head yet, set this node as head
                    if (head == null)
                    {
                        head = cursor2;
                        cursor = head;
                    }
                    // Otherwise set it as the next of the current node and move the cursor
                    else
                    {
                        cursor.next = cursor2; // Se the new node in the merged list
                        cursor = cursor.next; // Advance cursor
                    }

                    cursor2.next = null; // This node was detached from the original list so it doesn't need a next anymore
                    cursor2 = next; // Set its old next as the new head of the partial list
                }
            }
        }

        return head;
    }

    // NOTE: This solution does not modify the original lists, it creates new nodes
    public static ListNode MergeTwoListsRecursive(ListNode list1, ListNode list2)
    {
        if (list1 == null)
        {
            return list2;
        }

        if (list2 == null)
        {
            return list1;
        }

        var node = new ListNode();

        if (list1.val < list2.val)
        {
            node.val = list1.val;
            node.next = MergeTwoListsRecursive(list1.next, list2);
        }
        else
        {
            node.val = list2.val;
            node.next = MergeTwoListsRecursive(list1, list2.next);
        }

        return node;
    }

    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }

        public static ListNode FromArray(int[] array)
        {
            if (array == null)
            {
                throw new ArgumentNullException(nameof(array));
            }

            if (array.Length == 0)
            {
                return null;
            }

            var root = new ListNode
            {
                val = array[0]
            };

            var curr = root;

            for (int i = 1; i < array.Length; i++)
            {
                var next = new ListNode
                {
                    val = array[i]
                };

                curr.next = next;
                curr = curr.next;
            }

            return root;
        }

        public int[] ToArray()
        {
            var list = new List<int>();
            var curr = this;

            do
            {
                list.Add(curr.val);
                curr = curr.next;
            }
            while (curr != null);

            return list.ToArray(); // Expensive but it's here just for testing purposes, not used in the actual code.
        }

        public override string ToString() => $"Value: {val}";
    }
}
