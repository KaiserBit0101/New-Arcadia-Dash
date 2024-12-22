using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerControl : MonoBehaviour
{
    public bool controlsActive = false;
    public bool activatingStart = false;
    public GameObject playerObject;
    public bool isJumping = false;
    public AudioSource jumpSound;
    public GameObject footSteps;
    public bool comingDown = false;
    public GameObject dustParts;
    public GameObject longFadeIn;
    public GameObject getReadyText;
    public GameObject goText;
    public AudioSource getReadyFX;
    public AudioSource goFX;
    public GameObject scoreKeeper;
    public float internalSpeed = 8;
    public bool increasingSpeed = false;
    public int leftRightSpeed = 3;
    public static bool externalControls;
    public static bool joyTest;
    public bool internalJoyTest;


    void Start()
    {
        comingDown = false;
        isJumping = false;
        GlobalCollisionDetect.hasCollided = false; // Eğer gerekli ise sıfırla
        transform.position = new Vector3(transform.position.x, 1.5f, transform.position.z); // Yükseklik sıfırla
        playerObject.GetComponent<Animator>().Play("Standard Run");
    }
    void OnEnable()
    {
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    void OnDisable()
    {
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }

    void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        comingDown = false;
        isJumping = false;
        GlobalCollisionDetect.hasCollided = false; // Statik değişken sıfırlama (gerekliyse)
    }
    void Update()
    {
      
        externalControls = controlsActive;
        if (controlsActive == false && activatingStart == false)
        {
            activatingStart = true;
            StartCoroutine(StartSequence());
        }
        transform.Translate(Vector3.forward * Time.deltaTime * internalSpeed);
        if(increasingSpeed == false)
        {
            increasingSpeed = true;
            StartCoroutine(SpeedIncrease());
        }
        if (controlsActive == true)
        {
            if (joyTest == false)
            {
                if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
                {
                    if (this.gameObject.transform.position.x > DesertBoundary.leftSide)
                    {
                        transform.Translate(Vector3.left * Time.deltaTime * leftRightSpeed);
                    }
                }
                if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
                {
                    if (this.gameObject.transform.position.x < DesertBoundary.rightSide)
                    {
                        transform.Translate(Vector3.left * Time.deltaTime * leftRightSpeed * -1);
                    }
                }
                if (Input.GetKey(KeyCode.Space) || Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
                {
                    if (isJumping == false)
                    {
                        footSteps.SetActive(false);
                        jumpSound.Play();
                        playerObject.GetComponent<Animator>().Play("Jump");
                        StartCoroutine(JumpKey());
                        isJumping = true;

                     

                    }
                }
            }
            else
            {
                if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow) || (Input.GetAxis("Horizontal") < 0))
                {
                    if (this.gameObject.transform.position.x > DesertBoundary.leftSide)
                    {
                        transform.Translate(Vector3.left * Time.deltaTime * leftRightSpeed);
                    }
                }
                if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow) || (Input.GetAxis("Horizontal") > 0))
                {
                    if (this.gameObject.transform.position.x < DesertBoundary.rightSide)
                    {
                        transform.Translate(Vector3.left * Time.deltaTime * leftRightSpeed * -1);
                    }
                }
                if (Input.GetKey(KeyCode.Space) || Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow) || Input.GetButton("Jump"))
                {
                    if (isJumping == false)
                    {
                        footSteps.SetActive(false);
                        jumpSound.Play();
                        playerObject.GetComponent<Animator>().Play("Jump");
                        StartCoroutine(JumpKey());
                        isJumping = true;

                        

                    }
                }
            }
        }

        //test control

        if (isJumping == true)
        {
            if (comingDown == false)
            {
                transform.Translate(Vector3.up * Time.deltaTime * 3, Space.World);
            }
            if (comingDown == true)
            {
                transform.Translate(Vector3.up * Time.deltaTime * -3, Space.World);
            }
        }
    }

    IEnumerator JumpKey()
    {
        comingDown = false;  // her başlatıldığında sıfırlanıyor
        if (GlobalCollisionDetect.hasCollided == false)
        {
            yield return new WaitForSeconds(0.525f);
            comingDown = true;
            yield return new WaitForSeconds(0.525f);
        }
        if (GlobalCollisionDetect.hasCollided == false)
        {
            playerObject.GetComponent<Animator>().Play("Standard Run");
            transform.position = new Vector3(this.gameObject.transform.localPosition.x, 1.5f, this.gameObject.transform.localPosition.z);
            dustParts.GetComponent<ParticleSystem>().startSize = 1;
            comingDown = false;
            isJumping = false;
            footSteps.SetActive(true);
        }
    }

    IEnumerator StartSequence()
    {
        //runs once per load
        yield return new WaitForSeconds(1.8f);
        longFadeIn.SetActive(false);
        getReadyFX.Play();
        getReadyText.SetActive(true);
        yield return new WaitForSeconds(2);
        getReadyText.SetActive(false);
        yield return new WaitForSeconds(0.25f);
        controlsActive = true;
        scoreKeeper.SetActive(true);
        goText.SetActive(true);
        goFX.Play();
        yield return new WaitForSeconds(1);
        goText.SetActive(false);
    }

    IEnumerator SpeedIncrease()
    {
        yield return new WaitForSeconds(10);
        internalSpeed += 0.5f;
        increasingSpeed = false;
    }
}
