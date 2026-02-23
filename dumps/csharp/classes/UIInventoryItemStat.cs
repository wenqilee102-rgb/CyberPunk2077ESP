using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class UIInventoryItemStat : IScriptable
	{
		private CEnum<gamedataStatType> _type;
		private CFloat _value;
		private CHandle<IUIInventoryItemStatsProvider> _propertiesProvider;
		private CHandle<UIItemStatProperties> _properties;
		private CBool _propertiesFetched;

		[Ordinal(0)] 
		[RED("Type")] 
		public CEnum<gamedataStatType> Type
		{
			get => GetProperty(ref _type);
			set => SetProperty(ref _type, value);
		}

		[Ordinal(1)] 
		[RED("Value")] 
		public CFloat Value
		{
			get => GetProperty(ref _value);
			set => SetProperty(ref _value, value);
		}

		[Ordinal(2)] 
		[RED("PropertiesProvider")] 
		public CHandle<IUIInventoryItemStatsProvider> PropertiesProvider
		{
			get => GetProperty(ref _propertiesProvider);
			set => SetProperty(ref _propertiesProvider, value);
		}

		[Ordinal(3)] 
		[RED("properties")] 
		public CHandle<UIItemStatProperties> Properties
		{
			get => GetProperty(ref _properties);
			set => SetProperty(ref _properties, value);
		}

		[Ordinal(4)] 
		[RED("propertiesFetched")] 
		public CBool PropertiesFetched
		{
			get => GetProperty(ref _propertiesFetched);
			set => SetProperty(ref _propertiesFetched, value);
		}

		public UIInventoryItemStat(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
