using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PickupPhoneRequest : gameScriptableSystemRequest
	{
		private questPhoneCallInformation _callInformation;
		private CBool _shouldBeRejected;

		[Ordinal(0)] 
		[RED("CallInformation")] 
		public questPhoneCallInformation CallInformation
		{
			get => GetProperty(ref _callInformation);
			set => SetProperty(ref _callInformation, value);
		}

		[Ordinal(1)] 
		[RED("shouldBeRejected")] 
		public CBool ShouldBeRejected
		{
			get => GetProperty(ref _shouldBeRejected);
			set => SetProperty(ref _shouldBeRejected, value);
		}

		public PickupPhoneRequest(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
