using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class WrappedUIInventoryItem : IScriptable
	{
		private wCHandle<UIInventoryItem> _item;
		private CHandle<IScriptable> _additionalData;

		[Ordinal(0)] 
		[RED("Item")] 
		public wCHandle<UIInventoryItem> Item
		{
			get => GetProperty(ref _item);
			set => SetProperty(ref _item, value);
		}

		[Ordinal(1)] 
		[RED("AdditionalData")] 
		public CHandle<IScriptable> AdditionalData
		{
			get => GetProperty(ref _additionalData);
			set => SetProperty(ref _additionalData, value);
		}

		public WrappedUIInventoryItem(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
