using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class RipperdocCyberwareEquipAnimationCategory : IScriptable
	{
		private CName _factName;
		private CArray<CEnum<gamedataEquipmentArea>> _equipAreas;
		private CFloat _weight;
		private CInt32 _equipCount;

		[Ordinal(0)] 
		[RED("factName")] 
		public CName FactName
		{
			get => GetProperty(ref _factName);
			set => SetProperty(ref _factName, value);
		}

		[Ordinal(1)] 
		[RED("equipAreas")] 
		public CArray<CEnum<gamedataEquipmentArea>> EquipAreas
		{
			get => GetProperty(ref _equipAreas);
			set => SetProperty(ref _equipAreas, value);
		}

		[Ordinal(2)] 
		[RED("weight")] 
		public CFloat Weight
		{
			get => GetProperty(ref _weight);
			set => SetProperty(ref _weight, value);
		}

		[Ordinal(3)] 
		[RED("equipCount")] 
		public CInt32 EquipCount
		{
			get => GetProperty(ref _equipCount);
			set => SetProperty(ref _equipCount, value);
		}

		public RipperdocCyberwareEquipAnimationCategory(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
