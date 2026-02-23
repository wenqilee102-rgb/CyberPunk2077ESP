using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class workDynamicSyncBindAnimComponentCommandData : workSyncBindBaseCommandData
	{
		private wCHandle<entAnimationControllerComponent> _slave;

		[Ordinal(0)] 
		[RED("slave")] 
		public wCHandle<entAnimationControllerComponent> Slave
		{
			get => GetProperty(ref _slave);
			set => SetProperty(ref _slave, value);
		}

		public workDynamicSyncBindAnimComponentCommandData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
