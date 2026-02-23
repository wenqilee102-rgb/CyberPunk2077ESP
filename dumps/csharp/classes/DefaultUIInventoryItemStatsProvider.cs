using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DefaultUIInventoryItemStatsProvider : IUIInventoryItemStatsProvider
	{
		private CEnum<gamedataStatType> _statType;
		private wCHandle<UIInventoryItemsManager> _manager;

		[Ordinal(0)] 
		[RED("statType")] 
		public CEnum<gamedataStatType> StatType
		{
			get => GetProperty(ref _statType);
			set => SetProperty(ref _statType, value);
		}

		[Ordinal(1)] 
		[RED("manager")] 
		public wCHandle<UIInventoryItemsManager> Manager
		{
			get => GetProperty(ref _manager);
			set => SetProperty(ref _manager, value);
		}

		public DefaultUIInventoryItemStatsProvider(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
