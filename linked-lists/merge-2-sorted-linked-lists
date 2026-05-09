
public ListNode MergeTwoLists(ListNode list1, ListNode list2) {
    ListNode list3 = null;
    ListNode endOfList3 = null;

    while (true)
    {
        ListNode node = null;

        if (list1 == null && list2 == null)
        {
            break;
        }
        else if (list1 == null || list1.val > list2?.val)
        {
            node = list2;
            list2 = list2.next;
        }
        else
        {
            node = list1;
            list1 = list1.next;
        }

        if (list3 == null)
        {
            list3 = node;
        }
        else
        {
            endOfList3.next = node;
        }

        endOfList3 = node;
    }

    return list3;
}
