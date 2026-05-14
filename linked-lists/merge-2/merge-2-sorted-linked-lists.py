class Solution(object):
    def mergeTwoLists(self, list1, list2):
        """
        :type list1: Optional[ListNode]
        :type list2: Optional[ListNode]
        :rtype: Optional[ListNode]
        """
        
        dummy_head = ListNode()
        node = dummy_head

        while list1 and list2:
            if list1.val < list2.val:
                node.next = list1
                node = node.next
                list1 = list1.next
            elif list1.val >= list2.val:
                node.next = list2
                node = node.next
                list2 = list2.next

        if list1:
            node.next = list1
        elif list2:
            node.next = list2

        return dummy_head.next
