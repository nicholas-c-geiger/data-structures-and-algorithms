class Solution:
    def isAnagram(self, s: str, t: str) -> bool:
        seen = {}

        for c in s:
            if c in seen:
                seen[c] += 1
            else:
                seen[c] = 1

        for c in t:
            if c in seen:
                if seen[c] > 1:
                    seen[c] -= 1
                else:
                    del seen[c]
            else:
                return False

        return len(seen) == 0
