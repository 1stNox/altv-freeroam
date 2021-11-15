import { onServer, log } from 'alt-client';
onServer("Command:Pos:Print", (pos) => {
    log('X: ' + pos.x + ' Y: ' + pos.y + ' Z: ' + pos.z);
});
onServer("Command:Rot:Print", (rot) => {
    log('Roll: ' + rot.x + ' Pitch: ' + rot.y + ' Yaw: ' + rot.z);
});
