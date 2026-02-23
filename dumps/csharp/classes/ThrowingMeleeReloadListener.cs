using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ThrowingMeleeReloadListener : gameScriptStatPoolsListener
	{
		private wCHandle<MeleeProjectile> _melee;

		[Ordinal(0)] 
		[RED("melee")] 
		public wCHandle<MeleeProjectile> Melee
		{
			get => GetProperty(ref _melee);
			set => SetProperty(ref _melee, value);
		}

		public ThrowingMeleeReloadListener(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
