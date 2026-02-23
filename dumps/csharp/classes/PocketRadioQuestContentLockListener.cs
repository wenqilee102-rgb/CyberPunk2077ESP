using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PocketRadioQuestContentLockListener : questScriptQuestContentLockListener
	{
		private CHandle<PocketRadio> _pocketRadio;

		[Ordinal(0)] 
		[RED("pocketRadio")] 
		public CHandle<PocketRadio> PocketRadio
		{
			get => GetProperty(ref _pocketRadio);
			set => SetProperty(ref _pocketRadio, value);
		}

		public PocketRadioQuestContentLockListener(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
