using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class HitIsRarityPrereq : GenericHitPrereq
	{
		private CBool _invert;
		private CEnum<gamedataNPCRarity> _rarity;

		[Ordinal(8)] 
		[RED("invert")] 
		public CBool Invert
		{
			get => GetProperty(ref _invert);
			set => SetProperty(ref _invert, value);
		}

		[Ordinal(9)] 
		[RED("rarity")] 
		public CEnum<gamedataNPCRarity> Rarity
		{
			get => GetProperty(ref _rarity);
			set => SetProperty(ref _rarity, value);
		}

		public HitIsRarityPrereq(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
