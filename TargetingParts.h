#pragma once

namespace TargetingParts
{
    enum PartIndex : int
    {
        Chest = 0,
        LeftHand = 1,
        RightHand = 2,
        LeftLeg = 3,
        Head = 4,
        RightLeg = 5,
        Neck = 6
    };

    enum BodyPartCategory : int
    {
        CategoryHead = 0,
        CategoryChest = 1,
        CategoryLimbs = 2
    };

    inline bool IsHeadPart(int partIndex)
    {
        return partIndex == PartIndex::Head;
    }

    inline bool IsChestPart(int partIndex)
    {
        return partIndex == PartIndex::Chest || partIndex == PartIndex::Neck;
    }

    inline bool IsLimbsPart(int partIndex)
    {
        return partIndex == PartIndex::LeftHand ||
               partIndex == PartIndex::RightHand ||
               partIndex == PartIndex::LeftLeg ||
               partIndex == PartIndex::RightLeg;
    }

    inline bool ShouldSelectPart(int partIndex, int category)
    {
        switch (category)
        {
        case CategoryHead:
            return IsHeadPart(partIndex);
        case CategoryChest:
            return IsChestPart(partIndex);
        case CategoryLimbs:
            return IsLimbsPart(partIndex);
        default:
            return false;
        }
    }

    inline const char* GetPartName(int partIndex)
    {
        switch (partIndex)
        {
        case PartIndex::Chest: return "Chest";
        case PartIndex::LeftHand: return "LeftHand";
        case PartIndex::RightHand: return "RightHand";
        case PartIndex::LeftLeg: return "LeftLeg";
        case PartIndex::Head: return "Head";
        case PartIndex::RightLeg: return "RightLeg";
        case PartIndex::Neck: return "Neck";
        default: return "Unknown";
        }
    }

    inline const char* GetCategoryName(int category)
    {
        switch (category)
        {
        case CategoryHead: return "Head";
        case CategoryChest: return "Chest";
        case CategoryLimbs: return "Limbs";
        default: return "Unknown";
        }
    }
}
