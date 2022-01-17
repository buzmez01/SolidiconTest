using System;
using UnityEngine;

public static class BallTransformSystem
{
    public static Vector3 linePoint;
    public static Vector3 lineVector;

    public static void Run(GameObject ball)
    {
        var time = Data.HighlightTime;
        var activeGame = Data.SequenceData;
        var ballTransforms = activeGame.BallTransforms;
        int sequenceLength = Data.SequenceMetaData.TotalSteps;
        float progress = time / sequenceLength;
        progress = Math.Min(1, progress);
        int length = sequenceLength - 1;
        float stepIndexFloat = progress * length;
        int step1Index = (int)(stepIndexFloat);
        int step2Index = Math.Min(length, step1Index + 1);
        float stepProgress = stepIndexFloat - step1Index;

        var stepTransform = ballTransforms[step1Index];
        var nextStepTransform = ballTransforms[step2Index];

        var pos1 = stepTransform.Position;
        var pos2 = nextStepTransform.Position;
        Vector3 newPos = Vector3.Lerp(pos1, pos2, stepProgress);
        newPos = Vector3.Scale(Data.PlayerScale, newPos);
        ball.transform.position = newPos;

        // ------------ My Coding Part ---------- //

        //float distance = 50f;
        Vector3 pos2NonY = new Vector3(pos2.x, 0, pos2.z);
        Vector3 pos1NonY = new Vector3(pos1.x, 0, pos1.z);
        linePoint = newPos;
        lineVector = pos2NonY - pos1NonY;

        //Debug.DrawRay(newPos, (pos2NonY - pos1NonY) * distance);

        Ray ray = new Ray(newPos, (lineVector));
        Debug.DrawRay(ray.origin, ray.direction * 10);
        RaycastHit hitData;

        if (Physics.Raycast(ray, out hitData))
        {
            //Debug.Log(hitData.transform.name);
            Debug.Log(hitData.collider.gameObject.name);
        }


        // ------------ My Coding Part Ended ---------- //

        var rot1 = stepTransform.Rotation;//Direction;
        var rot2 = nextStepTransform.Rotation;
        Vector3 newDir = Vector3.Lerp(rot1, rot2, stepProgress);
        if (newDir != Vector3.zero)
        {
            ball.transform.rotation = Quaternion.LookRotation(newDir);
        }
    }

}