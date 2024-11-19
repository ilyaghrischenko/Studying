#region classes
class Processor:
    def __init__(self, model, cores, speed):
        self.model = model
        self.cores = cores
        self.speed = speed

    def __str__(self):
        return f"Processor(Model: {self.model}, Cores: {self.cores}, Speed: {self.speed} GHz)"


class GraphicsCard:
    def __init__(self, model, memory):
        self.model = model
        self.memory = memory

    def __str__(self):
        return f"GraphicsCard(Model: {self.model}, Memory: {self.memory} GB)"


class RAM:
    def __init__(self, size):
        self.size = size

    def __str__(self):
        return f"RAM(Size: {self.size} GB)"


class Mouse:
    def __init__(self, model, type_):
        self.model = model
        self.type = type_

    def __str__(self):
        return f"Mouse(Model: {self.model}, Type: {self.type})"


class Printer:
    def __init__(self, model, type_):
        self.model = model
        self.type = type_

    def __str__(self):
        return f"Printer(Model: {self.model}, Type: {self.type})"


class Computer:
    def __init__(self, processor, graphics_card, ram, mouse, printer):
        self.processor = processor
        self.graphics_card = graphics_card
        self.ram = ram
        self.mouse = mouse
        self.printer = printer

    def __str__(self):
        return (f"Computer:\n"
                f"  {self.processor}\n"
                f"  {self.graphics_card}\n"
                f"  {self.ram}\n"
                f"  {self.mouse}\n"
                f"  {self.printer}")
#endregion

processor = Processor("Intel i7-11700K", 8, 3.6)
graphics_card = GraphicsCard("NVIDIA GeForce RTX 3060", 12)
ram = RAM(16)
mouse = Mouse("Logitech G502", "Wired")
printer = Printer("HP LaserJet Pro M404", "Laser")

computer = Computer(processor, graphics_card, ram, mouse, printer)

print(computer)
