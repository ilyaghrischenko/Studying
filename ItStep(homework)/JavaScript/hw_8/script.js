class RepairCalculator {
    constructor() {
        this.typeSelect = document.querySelector('select[name="type_bulding"]');
        this.addRoomButton = document.querySelector('.rooms_add');
        this.calculateButton = document.querySelector('.rooms__calculate');
        this.roomsContainer = document.querySelector('.calculator__add');
        this.totalCostElement = document.querySelector('.price');
        this.iconElement = document.querySelector('.calculator__icon img');
        this.roomTemplate = document.querySelector('.rooms').cloneNode(true);
        this.rooms = [document.querySelector('.rooms')];

        this.attachEventListeners();
    }

    attachEventListeners() {
        this.addRoomButton.addEventListener('click', () => this.addRoom());
        this.calculateButton.addEventListener('click', () => this.calculateTotal());
        this.typeSelect.addEventListener('change', () => this.updateIcon());

        this.rooms[0].querySelector('.rooms__square').addEventListener('input', () => this.calculateTotal());
    }

    addRoom() {
        if (this.rooms.length >= 5) return;

        const newRoom = this.roomTemplate.cloneNode(true);

        newRoom.querySelector('.rooms_add').classList.add('rooms__btn--hidden');
        newRoom.querySelector('.rooms_del').classList.remove('rooms__btn--hidden');
        newRoom.querySelector('.rooms_del').addEventListener('click', () => this.removeRoom(newRoom));

        newRoom.querySelector('.rooms__square').addEventListener('input', () => this.calculateTotal());

        this.rooms.push(newRoom);
        this.roomsContainer.appendChild(newRoom);
    }

    removeRoom(room) {
        this.rooms = this.rooms.filter(r => r !== room);
        room.remove();
        this.calculateTotal();
    }

    calculateTotal() {
        const baseCostPerSquareMeter = parseFloat(this.typeSelect.value) || 0;
        let totalSquareMeters = 0;

        this.rooms.forEach(room => {
            const squareInput = room.querySelector('.rooms__square');
            const squareValue = parseFloat(squareInput.value) || 0;
            totalSquareMeters += squareValue;
        });

        const totalCost = baseCostPerSquareMeter * totalSquareMeters;
        console.log("Total cost calculated:", totalCost); 
        this.totalCostElement.textContent = totalCost.toFixed(2);
    }

    updateIcon() {
        const buildingType = this.typeSelect.value;
        let iconSrc;

        switch (buildingType) {
            case '100':
                iconSrc = 'pic/home.png';
                break;
            case '300':
                iconSrc = 'pic/apartment.png';
                break;
            case '500':
                iconSrc = 'pic/office.png';
                break;
            default:
                iconSrc = 'pic/home.png';
                break;
        }

        this.iconElement.src = iconSrc;
    }
}

document.addEventListener('DOMContentLoaded', () => {
    new RepairCalculator();
});
