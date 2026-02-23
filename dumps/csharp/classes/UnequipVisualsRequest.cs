using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class UnequipVisualsRequest : gamePlayerScriptableSystemRequest
	{
		private CEnum<gamedataEquipmentArea> _area;
		private CBool _removeItem;

		[Ordinal(1)] 
		[RED("area")] 
		public CEnum<gamedataEquipmentArea> Area
		{
			get => GetProperty(ref _area);
			set => SetProperty(ref _area, value);
		}

		[Ordinal(2)] 
		[RED("removeItem")] 
		public CBool RemoveItem
		{
			get => GetProperty(ref _removeItem);
			set => SetProperty(ref _removeItem, value);
		}

		public UnequipVisualsRequest(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
