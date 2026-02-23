using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class NpcNameplateVisualData : CVariable
	{
		private gameuiNPCNextToTheCrosshair _npcNextToCrosshair;

		[Ordinal(0)] 
		[RED("npcNextToCrosshair")] 
		public gameuiNPCNextToTheCrosshair NpcNextToCrosshair
		{
			get => GetProperty(ref _npcNextToCrosshair);
			set => SetProperty(ref _npcNextToCrosshair, value);
		}

		public NpcNameplateVisualData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
