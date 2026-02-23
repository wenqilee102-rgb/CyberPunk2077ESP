using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameAVSpawnPointsRequestResult : CVariable
	{
		private CUInt32 _requestID;
		private CBool _success;
		private CArray<Vector3> _spawnPoints;

		[Ordinal(0)] 
		[RED("requestID")] 
		public CUInt32 RequestID
		{
			get => GetProperty(ref _requestID);
			set => SetProperty(ref _requestID, value);
		}

		[Ordinal(1)] 
		[RED("success")] 
		public CBool Success
		{
			get => GetProperty(ref _success);
			set => SetProperty(ref _success, value);
		}

		[Ordinal(2)] 
		[RED("spawnPoints")] 
		public CArray<Vector3> SpawnPoints
		{
			get => GetProperty(ref _spawnPoints);
			set => SetProperty(ref _spawnPoints, value);
		}

		public gameAVSpawnPointsRequestResult(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
