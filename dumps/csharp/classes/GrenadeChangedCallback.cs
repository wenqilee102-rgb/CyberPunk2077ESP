using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class GrenadeChangedCallback : gameAttachmentSlotsScriptCallback
	{
		private wCHandle<gameObject> _grenadeChangeEntity;
		private CHandle<gameAttachmentSlotsScriptListener> _grenadeChangeListener;

		[Ordinal(2)] 
		[RED("grenadeChangeEntity")] 
		public wCHandle<gameObject> GrenadeChangeEntity
		{
			get => GetProperty(ref _grenadeChangeEntity);
			set => SetProperty(ref _grenadeChangeEntity, value);
		}

		[Ordinal(3)] 
		[RED("grenadeChangeListener")] 
		public CHandle<gameAttachmentSlotsScriptListener> GrenadeChangeListener
		{
			get => GetProperty(ref _grenadeChangeListener);
			set => SetProperty(ref _grenadeChangeListener, value);
		}

		public GrenadeChangedCallback(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
