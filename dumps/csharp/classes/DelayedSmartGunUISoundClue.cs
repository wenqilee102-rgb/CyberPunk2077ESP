using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DelayedSmartGunUISoundClue : gameDelaySystemScriptedDelayCallbackWrapper
	{
		private wCHandle<gameObject> _puppet;
		private CName _audioEventName;

		[Ordinal(0)] 
		[RED("puppet")] 
		public wCHandle<gameObject> Puppet
		{
			get => GetProperty(ref _puppet);
			set => SetProperty(ref _puppet, value);
		}

		[Ordinal(1)] 
		[RED("audioEventName")] 
		public CName AudioEventName
		{
			get => GetProperty(ref _audioEventName);
			set => SetProperty(ref _audioEventName, value);
		}

		public DelayedSmartGunUISoundClue(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
