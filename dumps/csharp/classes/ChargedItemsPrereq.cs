using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ChargedItemsPrereq : gameIScriptablePrereq
	{
		private CEnum<EChargesAmount> _chargesToCheck;
		private CEnum<EChargesItem> _typeOfItem;

		[Ordinal(0)] 
		[RED("chargesToCheck")] 
		public CEnum<EChargesAmount> ChargesToCheck
		{
			get => GetProperty(ref _chargesToCheck);
			set => SetProperty(ref _chargesToCheck, value);
		}

		[Ordinal(1)] 
		[RED("typeOfItem")] 
		public CEnum<EChargesItem> TypeOfItem
		{
			get => GetProperty(ref _typeOfItem);
			set => SetProperty(ref _typeOfItem, value);
		}

		public ChargedItemsPrereq(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
