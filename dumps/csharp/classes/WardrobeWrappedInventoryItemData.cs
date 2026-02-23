using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class WardrobeWrappedInventoryItemData : WrappedInventoryItemData
	{
		private CString _appearanceName;

		[Ordinal(11)] 
		[RED("AppearanceName")] 
		public CString AppearanceName
		{
			get => GetProperty(ref _appearanceName);
			set => SetProperty(ref _appearanceName, value);
		}

		public WardrobeWrappedInventoryItemData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
