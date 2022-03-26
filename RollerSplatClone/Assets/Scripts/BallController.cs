using UnityEngine;
using Random = UnityEngine.Random;

public class BallController : MonoBehaviour
{
   #region VARIABLES
   public Rigidbody rb;
   public float speed = 15;
   public bool isTraveling;
   private Vector3 _travelDirection;
   private Vector3 _nextCollisionPosition;
   public int minSwipeRecognition = 1000;
   private Vector2 _swipePosLastFrame;
   private Vector2 _swipePosCurrentFrame;
   private Vector2 _currentSwipe;
   public Color solveColor;
   public ParticleSystem poof;
   public Transform ball;
   public Transform insideBall;
   private float _ballPosX;  
   private float _ballPosZ;
   public TrailRenderer ballTrailRenderer;
   private Color[] _Colors =
   {
      DarkBlue, Cyan, DarkOrange, Lime, Magenta, MediumSpringGreen, DarkGreen, DeepPink,
      DeepSkyBlue, FireBrick, Purple, ForestGreen, SaddleBrown, Gold, SpringGreen, Tan, Yellow, Red, Coral
   };

   #endregion

   #region COLORS

   private static readonly Color DarkBlue = new Color32(0,0,139, 255);
   private static readonly Color Cyan = new Color32(0,255,255, 255);
   private static readonly Color DarkOrange = new Color32(255,140,0, 255);
   private static readonly Color Lime = new Color32(0,255,0, 255);
   private static readonly Color Magenta = new Color32(255,0,255, 255);
   private static readonly Color MediumSpringGreen = new Color32(0,250,154, 255);
   private static readonly Color DarkGreen = new Color32(0,100,0, 255);
   private static readonly Color DeepPink = new Color32(255,20,147, 255);
   private static readonly Color DeepSkyBlue = new Color32(0,191,255, 255);
   private static readonly Color FireBrick = new Color32(178,34,34, 255);
   private static readonly Color Purple = new Color32(128,0,128, 255);
   private static readonly Color ForestGreen = new Color32(34,139,34, 255);
   private static readonly Color SaddleBrown = new Color32(139,69,19, 255);
   private static readonly Color Gold = new Color32(255,215,0, 255);
   private static readonly Color SpringGreen = new Color32(0,255,127, 255);
   private static readonly Color Tan = new Color32(210,180,140, 255);
   private static readonly Color Yellow = new Color32(255,255,0, 255);
   private static readonly Color Red = new Color32(255,0,0, 255);
   private static readonly Color Coral = new Color32(255,127,80, 255);

   #endregion

   private void Start()
   {
      int r = Random.Range(0, _Colors.Length);
      solveColor = _Colors[r];
      insideBall.GetComponent<MeshRenderer>().materials[0].color = solveColor;
      ballTrailRenderer.material.color = solveColor;
   }

   
   private void FixedUpdate()
   {
      SwipeAction();

   }

   private void SetDestination(Vector3 direction)
   {
      _ballPosX = ball.position.x;
      _travelDirection = direction;

      RaycastHit hit;
      if (Physics.Raycast(transform.position, direction, out hit, 100f))
      {
         _nextCollisionPosition = hit.point;
      }
      isTraveling = true;
   }

   private void SwipeAction()
   {
      if (!isTraveling)
      {
         insideBall.Rotate(0,0,0);
      }
      if (isTraveling)
      {
         if (ball.position.x > _ballPosX)
         {
            insideBall.Rotate(0, 0, -speed * 3f);
         }
         else if (ball.position.x < _ballPosX)
         {
            insideBall.Rotate(0, 0, speed * 3f);
         }
         else if (ball.position.z > _ballPosZ)
         {
            insideBall.Rotate(speed * 3f, 0, 0);
         }
         else if (ball.position.z < _ballPosZ)
         {
            insideBall.Rotate(-speed * 3f , 0, 0);
         }
         rb.velocity = speed * _travelDirection;
      }

      Collider[] hitColliders = Physics.OverlapSphere(transform.position - (Vector3.up/2), 0.05f);
      int i = 0;
      while (i<hitColliders.Length)
      {
         GroundPiece ground = hitColliders[i].transform.GetComponent<GroundPiece>();
         if (ground && !ground.isColored)
         {
            ground.ChangeColor(solveColor);
#pragma warning disable 618
            poof.startColor = solveColor;
#pragma warning restore 618
            poof.Play();
         }
         i++;
      }

      if (_nextCollisionPosition != Vector3.zero)
      {
         if (Vector3.Distance(transform.position, _nextCollisionPosition) < 1)
         {
            isTraveling = false;
            _travelDirection = Vector3.zero;
            _nextCollisionPosition = Vector3.zero;
            insideBall.Rotate(0,0,0);
         }
      }

      if (isTraveling)
         return;

      if (Input.GetMouseButton(0))
      {
         _swipePosCurrentFrame = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
         if (_swipePosLastFrame != Vector2.zero)
         {
            _currentSwipe = _swipePosCurrentFrame - _swipePosLastFrame;
            if (_currentSwipe.sqrMagnitude<minSwipeRecognition)
            {
               return;
            }
            _currentSwipe.Normalize();
            if (_currentSwipe.x > -0.5f && _currentSwipe.x < 0.5)
            {
               if(_currentSwipe.y>0){
                  SetDestination(Vector3.forward);
               }
               else{
                  SetDestination(Vector3.back);
               }
            }
            if (_currentSwipe.y > -0.5f && _currentSwipe.y < 0.5)
            {
               if(_currentSwipe.x>0){
                  SetDestination(Vector3.right);
               }
               else{
                  SetDestination(Vector3.left);
               }
            }
         }
         
         _swipePosLastFrame = _swipePosCurrentFrame;
      }

      if (Input.GetMouseButtonUp(0))
      {
         _swipePosLastFrame = Vector2.zero;
         _currentSwipe = Vector2.zero;
      }

   }

}
