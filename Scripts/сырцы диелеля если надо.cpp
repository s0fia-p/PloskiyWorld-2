#define IT_DOESNT_WORK_WITHOUT_IT_FOR_SOME_REASON __declspec(dllexport)
#include "opencv2\core\core.hpp"

extern "C"
{
	CvRNG rng = cvRNG(0xffffffff);
	unsigned x = cvRandInt(&rng);
	IT_DOESNT_WORK_WITHOUT_IT_FOR_SOME_REASON int get5()
	{
		return 15;
	}
}