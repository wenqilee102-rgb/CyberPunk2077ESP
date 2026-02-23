using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class MonowireSpreadableNPC : IScriptable
	{
		private wCHandle<NPCPuppet> _nPCPuppet;
		private CHandle<gameeventsHitEvent> _hitEvent;

		[Ordinal(0)] 
		[RED("NPCPuppet")] 
		public wCHandle<NPCPuppet> NPCPuppet
		{
			get => GetProperty(ref _nPCPuppet);
			set => SetProperty(ref _nPCPuppet, value);
		}

		[Ordinal(1)] 
		[RED("HitEvent")] 
		public CHandle<gameeventsHitEvent> HitEvent
		{
			get => GetProperty(ref _hitEvent);
			set => SetProperty(ref _hitEvent, value);
		}

		public MonowireSpreadableNPC(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
