using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ShardTooltipWrapper : ATooltipData
	{
		private wCHandle<gameJournalOnscreen> _data;
		private CHandle<ItemDisplayContextData> _displayContext;

		[Ordinal(0)] 
		[RED("data")] 
		public wCHandle<gameJournalOnscreen> Data
		{
			get => GetProperty(ref _data);
			set => SetProperty(ref _data, value);
		}

		[Ordinal(1)] 
		[RED("displayContext")] 
		public CHandle<ItemDisplayContextData> DisplayContext
		{
			get => GetProperty(ref _displayContext);
			set => SetProperty(ref _displayContext, value);
		}

		public ShardTooltipWrapper(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
