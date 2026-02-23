using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ReflexesMasterPerk1EffectorListener : gameScriptedDamageSystemListener
	{
		private CHandle<ReflexesMasterPerk1Effector> _owner;

		[Ordinal(0)] 
		[RED("owner")] 
		public CHandle<ReflexesMasterPerk1Effector> Owner
		{
			get => GetProperty(ref _owner);
			set => SetProperty(ref _owner, value);
		}

		public ReflexesMasterPerk1EffectorListener(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
