using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class RipperdocPerkHoverEvent : redEvent
	{
		private CBool _isHover;
		private CEnum<gamedataNewPerkSlotType> _area;
		private CEnum<gamedataNewPerkType> _type;
		private TweakDBID _attributeID;

		[Ordinal(0)] 
		[RED("IsHover")] 
		public CBool IsHover
		{
			get => GetProperty(ref _isHover);
			set => SetProperty(ref _isHover, value);
		}

		[Ordinal(1)] 
		[RED("Area")] 
		public CEnum<gamedataNewPerkSlotType> Area
		{
			get => GetProperty(ref _area);
			set => SetProperty(ref _area, value);
		}

		[Ordinal(2)] 
		[RED("Type")] 
		public CEnum<gamedataNewPerkType> Type
		{
			get => GetProperty(ref _type);
			set => SetProperty(ref _type, value);
		}

		[Ordinal(3)] 
		[RED("AttributeID")] 
		public TweakDBID AttributeID
		{
			get => GetProperty(ref _attributeID);
			set => SetProperty(ref _attributeID, value);
		}

		public RipperdocPerkHoverEvent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
