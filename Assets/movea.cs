using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class movea : MonoBehaviour
{
    private NavMeshAgent navMeshAgent;
    private Animator animator;
    public Transform target;


    private void Start()
    {
        // Lấy tham chiếu đến NavMeshAgent và Animator
        navMeshAgent = GetComponent<NavMeshAgent>();
        animator = GetComponent<Animator>();

        //// Thiết lập điểm đến ban đầu (ví dụ: player hoặc một điểm nào đó)
        //SetDestinationToPlayer();
    }

    private void Update()
    {
        //// Kiểm tra trạng thái di chuyển của NavMeshAgent
        //bool isMoving = navMeshAgent.remainingDistance > navMeshAgent.stoppingDistance;

        //// Kích hoạt hoạt hình chạy khi enemy di chuyển
        animator.SetBool("walk",true);
        navMeshAgent.SetDestination(target.transform.position);
    }

    // Thiết lập điểm đến cho enemy
    public void SetDestination(Vector3 destination)
    {
        navMeshAgent.SetDestination(destination);
    }

    // Thiết lập điểm đến cho enemy đến player (ví dụ)
    //public void SetDestinationToPlayer()
    //{
    //    GameObject player = GameObject.FindGameObjectWithTag("Player"); // Điều này giả sử bạn đã đặt tag "Player" cho đối tượng player
    //    if (player != null)
    //    {
    //        SetDestination(player.transform.position);
    //    }
    //}
}
