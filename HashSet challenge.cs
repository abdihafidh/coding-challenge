using System;
using System.Collections.Generic;

public class Solution
{
    public int solution(int[] A)
    {
        HashSet<int> abNumbers = new HashSet<int>();

        A = new int[] { -5, -3, -1, 0, 3, 6 };
        for (int i = 0; i < A.Length; i++)
        {
            abNumbers.Add(Math.Abs(A[i]));
        }
        return abNumbers.Count;
    }
}

public class Solution
{
    public int solution(int X, int Y, int D)
    {
        X = 10;
        Y = 85;
        D = 30;
        int jumpProgress = X;
        int count = 0;
        while (jumpProgress < Y)
        {
            jumpProgress += D;
            count++;
        }
        return count;
    }
}

public class Solution
{
    public ListNode MergeTwoLists(ListNode list1, ListNode list2)
    {
        list1 = new ListNode(1);
        list1.next = new ListNode(2);
        list1.next.next = new ListNode(4);

        list2 = new ListNode(1);
        list2.next = new ListNode(3);
        list2.next.next = new ListNode(4);

        var dummyList = new ListNode();
        var head = dummyList;

        while (list1 != null && list2 != null)
        {
            if (list1.val <= list2.val)
            {
                dummyList.next = list1;
                dummyList = dummyList.next;
                list1 = list1.next;
            }
            else
            {
                dummyList.next = list2;
                dummyList = dummyList.next;
                list2 = list2.next;
            }
        }
        if (list1 != null)
        {
            dummyList.next = list1;
        }
        else if (list2 != null)
        {
            dummyList.next = list2;
        }
        return head.next;
    }
}

public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        nums = new int[] { 2, 7, 11, 15 };
        target = 9;
        int[] result = new int[2];

        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = i + 1; j < nums.Length; j++)
            {
                if (nums[i] + nums[j] == target)
                {
                    result[0] = i;
                    result[1] = j;
                    return result;
                }
            }
        }
        return result;
    }
}