using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class KiroshiHighlightEffectorCallback : gameAttachmentSlotsScriptCallback
	{
		private CHandle<KiroshiHighlightEffector> _effector;

		[Ordinal(2)] 
		[RED("effector")] 
		public CHandle<KiroshiHighlightEffector> Effector
		{
			get => GetProperty(ref _effector);
			set => SetProperty(ref _effector, value);
		}

		public KiroshiHighlightEffectorCallback(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
