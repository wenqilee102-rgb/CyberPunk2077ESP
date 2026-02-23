using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldQuestPreventionNotifier : worldITriggerAreaNotifer
	{
		private CEnum<worldQuestPreventionNotifierType> _type;
		private CEnum<worldQuestPreventionNotifierActivation> _activation;

		[Ordinal(3)] 
		[RED("type")] 
		public CEnum<worldQuestPreventionNotifierType> Type
		{
			get => GetProperty(ref _type);
			set => SetProperty(ref _type, value);
		}

		[Ordinal(4)] 
		[RED("activation")] 
		public CEnum<worldQuestPreventionNotifierActivation> Activation
		{
			get => GetProperty(ref _activation);
			set => SetProperty(ref _activation, value);
		}

		public worldQuestPreventionNotifier(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
