using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class UIInventoryItemComparisonManager : IScriptable
	{
		private CArray<CHandle<UIInventoryItemStatComparison>> _comparedStats;
		private wCHandle<UIInventoryItem> _comparedItem;
		private CUInt64 _comparisonHash;

		[Ordinal(0)] 
		[RED("ComparedStats")] 
		public CArray<CHandle<UIInventoryItemStatComparison>> ComparedStats
		{
			get => GetProperty(ref _comparedStats);
			set => SetProperty(ref _comparedStats, value);
		}

		[Ordinal(1)] 
		[RED("ComparedItem")] 
		public wCHandle<UIInventoryItem> ComparedItem
		{
			get => GetProperty(ref _comparedItem);
			set => SetProperty(ref _comparedItem, value);
		}

		[Ordinal(2)] 
		[RED("comparisonHash")] 
		public CUInt64 ComparisonHash
		{
			get => GetProperty(ref _comparisonHash);
			set => SetProperty(ref _comparisonHash, value);
		}

		public UIInventoryItemComparisonManager(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
