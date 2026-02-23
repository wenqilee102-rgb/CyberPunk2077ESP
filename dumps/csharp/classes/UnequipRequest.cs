using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class UnequipRequest : gamePlayerScriptableSystemRequest
	{
		private CEnum<gamedataEquipmentArea> _areaType;
		private CInt32 _slotIndex;
		private CBool _force;

		[Ordinal(1)] 
		[RED("areaType")] 
		public CEnum<gamedataEquipmentArea> AreaType
		{
			get => GetProperty(ref _areaType);
			set => SetProperty(ref _areaType, value);
		}

		[Ordinal(2)] 
		[RED("slotIndex")] 
		public CInt32 SlotIndex
		{
			get => GetProperty(ref _slotIndex);
			set => SetProperty(ref _slotIndex, value);
		}

		[Ordinal(3)] 
		[RED("force")] 
		public CBool Force
		{
			get => GetProperty(ref _force);
			set => SetProperty(ref _force, value);
		}

		public UnequipRequest(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
