using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SimpleCanSwapWeapons : AIbehaviorconditionScript
	{
		private CBool _initialized;
		private CBool _result;
		private CArray<wCHandle<gamedataNPCEquipmentItem_Record>> _items;

		[Ordinal(0)] 
		[RED("initialized")] 
		public CBool Initialized
		{
			get => GetProperty(ref _initialized);
			set => SetProperty(ref _initialized, value);
		}

		[Ordinal(1)] 
		[RED("result")] 
		public CBool Result
		{
			get => GetProperty(ref _result);
			set => SetProperty(ref _result, value);
		}

		[Ordinal(2)] 
		[RED("items")] 
		public CArray<wCHandle<gamedataNPCEquipmentItem_Record>> Items
		{
			get => GetProperty(ref _items);
			set => SetProperty(ref _items, value);
		}

		public SimpleCanSwapWeapons(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
