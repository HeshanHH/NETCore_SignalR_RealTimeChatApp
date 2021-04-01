var createRoomBtn = document.getElementById('create-room-btn');
var createRoomModal = document.getElementById('create-room-modal');

// add event listner to createRoomBtn.
createRoomBtn.addEventListener('click', function () {
    // set active.
    createRoomModal.classList.add('active')
});

var closeModal = () => {
    createRoomModal.classList.remove('active');
};