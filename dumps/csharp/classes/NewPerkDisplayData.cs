using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class NewPerkDisplayData : BasePerkDisplayData
	{
		private CEnum<gamedataNewPerkSlotType> _area;
		private CEnum<gamedataNewPerkType> _type;
		private CBool _isRipperdoc;

		[Ordinal(10)] 
		[RED("area")] 
		public CEnum<gamedataNewPerkSlotType> Area
		{
			get => GetProperty(ref _area);
			set => SetProperty(ref _area, value);
		}

		[Ordinal(11)] 
		[RED("type")] 
		public CEnum<gamedataNewPerkType> Type
		{
			get => GetProperty(ref _type);
			set => SetProperty(ref _type, value);
		}

		[Ordinal(12)] 
		[RED("isRipperdoc")] 
		public CBool IsRipperdoc
		{
			get => GetProperty(ref _isRipperdoc);
			set => SetProperty(ref _isRipperdoc, value);
		}

		public NewPerkDisplayData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
