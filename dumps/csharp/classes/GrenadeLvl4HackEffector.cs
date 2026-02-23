using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class GrenadeLvl4HackEffector : gameEffector
	{
		private wCHandle<gameObject> _grenadeChangeEntity;
		private CHandle<gameAttachmentSlotsScriptListener> _grenadeChangedListener;

		[Ordinal(0)] 
		[RED("grenadeChangeEntity")] 
		public wCHandle<gameObject> GrenadeChangeEntity
		{
			get => GetProperty(ref _grenadeChangeEntity);
			set => SetProperty(ref _grenadeChangeEntity, value);
		}

		[Ordinal(1)] 
		[RED("grenadeChangedListener")] 
		public CHandle<gameAttachmentSlotsScriptListener> GrenadeChangedListener
		{
			get => GetProperty(ref _grenadeChangedListener);
			set => SetProperty(ref _grenadeChangedListener, value);
		}

		public GrenadeLvl4HackEffector(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
