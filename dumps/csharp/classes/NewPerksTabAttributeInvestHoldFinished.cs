using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class NewPerksTabAttributeInvestHoldFinished : redEvent
	{
		private CEnum<PerkMenuAttribute> _attribute;

		[Ordinal(0)] 
		[RED("attribute")] 
		public CEnum<PerkMenuAttribute> Attribute
		{
			get => GetProperty(ref _attribute);
			set => SetProperty(ref _attribute, value);
		}

		public NewPerksTabAttributeInvestHoldFinished(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
